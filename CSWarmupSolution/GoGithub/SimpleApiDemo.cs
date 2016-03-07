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
        /// <summary>
        /// A simple github demo: we access a user by his user name and displays the number
        /// of followers that he has on github.
        /// </summary>
        public async void DoGitDemo()
        {
            var github = new GitHubClient(new ProductHeaderValue("MyApps"));
            var user = await github.User.Get("jlhg");
            Console.WriteLine(user.Followers + " folks are interested in jlhg's space");
        }

       
    }
}
