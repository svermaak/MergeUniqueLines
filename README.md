
# MergeUniqueLines

This C# program merges unique lines from multiple input files, sorts them, and writes the result to an output file. It uses System.Diagnostics to track the execution time using a stopwatch. If there are fewer than two arguments, it displays usage instructions. The program reads each input file, adds unique lines to a HashSet, sorts all lines, and writes them to the destination file. If any errors occur, they are logged. Final statistics include the number of files processed, output file details, lines written, and execution time.

---

## ✅ Prerequisites
- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/en-us/download)  
  Check your version:

  ```
  dotnet --version
  ```
- [Git](https://git-scm.com/downloads)  
  Required to clone the repository.



## 🛠️ Build & Run Instructions
1.  Clone the Repository
    ```
    git clone https://github.com/svermaak/MergeUniqueLines.git
    cd MergeUniqueLines
    ```
    
2.  Restore NuGet Packages
    ```
    dotnet restore
    ```
    
3.  Build the Project
    ```
    dotnet build --configuration Release
    ```
    
4.  Run the Executable  
    After building, find the executable at:
    ```
    bin\Release\net6.0\MergeUniqueLines.exe
    ```
5.  Usage:
    ```
    Usage: MergeUniqueLines <outputFile> <inputFile1> <inputFile2> ...
    ```       

----------

## 📜 License

This project is licensed under the MIT License.