# .NET

## What?

- **.NET** (pronounced _"dot net"_) is a **software development platform** to build **desktop**, **web** and **mobile** applications.
- It lets developers build:
  - 🌐 Web applications and APIs
  - 📱 Mobile/desktop apps
  - 🎮 Games
  - ☁️ Cloud services
- Developed by Microsoft, in 2002.
- .NET Application does not run directly on Operating System. It's need .NET Runtime call CLR (Execution Environment)
- Supports multiple languages such as C#, VB, VC++, ect.

---

## Main parts of .NET

- Language: It Supports **30+** languages. **C#** is the king of all.
- .NET Runtime and CLI
- .NET Libraries
- SDK
- Application Frameworks: ASP.NET Core, .NET MAUI, WPF, WinForms, Blazer, ASP.NET Core Identity, Entity Framework Core

---

### .NET Libraries

**.NET Libraries** are pre-built code provided by .NET that makes application development easier and faster.

They provide functionality for things like:

- 📁 Files and folders
- 🌐 Networking
- 🔢 Collections and data structures
- 🧵 Threads and async programming
- 🔐 Security
- 📝 JSON/XML
- 🗄️ Database-related operations

### Example

Suppose you want to read a file.

Instead of writing the low-level code yourself, .NET provides the `File` class:

```csharp
using System.IO;

string text = File.ReadAllText("data.txt");

Console.WriteLine(text);
```

---

### .NET SDK

**SDK (Software Development Kit)** is a **set of tools** (compilers, templates and CLI).

It includes tools for:

- 🛠️ Creating projects
- 🔨 Building/compiling code
- 🧪 Testing
- 📦 Publishing applications
- ▶️ Running applications

### Example

After installing the .NET SDK, you can run:

```bash
dotnet new console
dotnet build
dotnet run
```

---

## Versions

- .NET Framework version 1.0 to 4.8.1
- .NET Core (Cross Platform) version 1.0 to 3.1
- .NET version 5.0 and so on
- CLR version 1,2,4 (no version 3)
- One major advantage of modern .NET (.NET Core) is that it is **cross-platform**, meaning applications can run on Windows, Linux, and macOS.

## .NET Core

- Introduce in 2016
- cross-platform
- Open Source
- Support 2 languages only, C#, VB.NET

## IDE - Integrated Development Environment

- Visual Studio - Full feature IDE
- Visual Studio Code - Lightweight
