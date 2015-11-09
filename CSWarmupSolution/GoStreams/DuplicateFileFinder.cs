using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStreams
{
    class DuplicateFileFinder
    {
        public static void GiveHelp()
        {
            Console.WriteLine("syntax: program_name [/recurse] folder [folder] ....");
            Console.WriteLine("The /recurse switch commands the tool to recursively iterate through the directories");
            Console.ReadKey();

        }
        public static void FindDuplicates(String[] args)
        {
            bool subDirectoriesRecursion = false;
            if (args.Length < 1)
            {
                GiveHelp();
                return;

            }

            int rootDirectoryIndex = 0;
            if (args.Length > 1)
            {
                if (args[0] == "/recurse")
                {
                    if (args.Length < 2)
                    {
                        GiveHelp();
                        return;
                    }
                    subDirectoriesRecursion = true;
                    rootDirectoryIndex = 1;

                }
            }

            var dirsToSearch = args.Skip(rootDirectoryIndex);
            List<FileInfosGroup> fileGroups = IterateFolders(subDirectoriesRecursion, dirsToSearch);

            Console.ReadKey();
           
        }

        static void ShowMatches(IEnumerable<FileInfosGroup> fileGroups)
        {
            var groupsWithManyFiles = from nameGroup in fileGroups
                                      where nameGroup.TargetedFiles.Count > 1
                                      select nameGroup;
            foreach (var fNG in groupsWithManyFiles)
            {
                var sizeMatches = from f in fNG.TargetedFiles
                                  group f by f.Size into sizeGroup
                                  where sizeGroup.Count() > 1
                                  select sizeGroup;

                foreach (var sizeMatch in sizeMatches)
                {
                    string fNAS = string.Format("{0} ({1} bytes)",
                        fNG.StrictFileName, sizeMatch.Key);
                    Console.WriteLine(fNAS);
                    Console.WriteLine(new string ('=', fNAS.Length));
                    foreach (var f in sizeMatch)
                    {
                        Console.WriteLine(Path.GetDirectoryName(f.Path));
                    }
                    Console.WriteLine();
                }

            }
        }

        static List<FileInfosGroup> IterateFolders(bool subDirectoriesRecursion, IEnumerable<String> foldersToIterate)
        {
            var searchOption = subDirectoriesRecursion ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var allFiles = from folder in foldersToIterate
                           from file in Directory.GetFiles(folder, "*.*", searchOption)
                           select file;
            var fileGroups = from path in allFiles
                             let strictFileName = Path.GetFileName(path)
                             group path by strictFileName into nameGroup
                             select new FileInfosGroup
                             {
                                 StrictFileName = nameGroup.Key,
                                 TargetedFiles =
                                 (from path in nameGroup
                                  let fInfo = new FileInfo(path)
                                  select new FileSearchInfos
                                  {
                                      Path = path,
                                      Size = fInfo.Length
                                  }).ToList()

                             };
            return fileGroups.ToList();

        }
    }
}
