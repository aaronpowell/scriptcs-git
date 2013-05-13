using System;
using LibGit2Sharp;

static Repository InitOrOpen(string path)
{
    var gitBasePath = Repository.Discover(path);
    if (gitBasePath == null)
    {
        Console.WriteLine("And we're creating a new git repo people!");
        return Repository.Init(path);
    }
    Console.WriteLine("Found existing repo, keep on trucking");
    return new Repository(gitBasePath);
}

using (var repo = InitOrOpen(@"C:\temp\git-fun\out"))
{
    Console.WriteLine("It's time to rock and rooooooooll");
}

Console.ReadLine();
