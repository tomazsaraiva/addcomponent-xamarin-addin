using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "AddComponent Extensions",
    Namespace = "addcomponent.extensions",
    Version = "1.0"
)]

[assembly: AddinName("Add Component Extensions")]
[assembly: AddinCategory("IDE Extensions")]
[assembly: AddinDescription("A bunch of new file templates to make your life a lot easier")]
[assembly: AddinAuthor("Tomaz Saraiva")]

[assembly: AddinDependency("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly: AddinDependency("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]