# UseDifferentDllsBasedOSPlatform
If you want to use different dlls for different platform in one project, you can need to editcsproj

1. Build lib 'ClassLibrary2' base on x86 and save the given dll to folder .\ConsoleApp2\86;
2. Build lib 'ClassLibrary2' base on x64 and save the given dll to folder .\ConsoleApp2\64;
3. Unload 'ClassLibrary2' from the project;
4. Run 'ConsoleApp2' on configuration 'Roman' and platform 'x86' and you see 86 and x86;
5. Run 'ConsoleApp2' on configuration 'Roman' and platform 'x64' and you see 64 and x64;
6. Copy settings from csproj for you applications.