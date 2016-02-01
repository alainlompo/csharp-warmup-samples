using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace GoGithub
{
    public class SimpleApiDemo
    {

        public async void DoGitDemo()
        {
            var github = new GitHubClient(new ProductHeaderValue("MyApps"));
            var user = await github.User.Get("jlhg");
            Console.WriteLine(user.Followers + " folks are interested in jlhg's space");
        }

       
    }
}
