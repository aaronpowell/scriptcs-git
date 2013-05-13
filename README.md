scriptcs-git
============

    scriptcs -install
    scriptcs app.csx

Expected:
- Creates or opens a git repo at `c:\temp\git-fun\out`

Actual:
- Exception because `git2.dll` can't be found (see [bug](https://github.com/libgit2/libgit2sharp/issues/431))
- Manually copying the `NativeBinaries` folder results in a `MetaDataReaderException` exception loading `git2.dll`
-- Exception: `ERROR: error CS0009: Metadata file 'C:\Users\aaron.powell\_Code\git-fun\bin\NativeBinaries\amd64\git2.dll' could not be opened -- 'MetadataReaderException: COR20HeaderTooSmall'`
