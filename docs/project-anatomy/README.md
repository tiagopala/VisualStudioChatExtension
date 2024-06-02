# Project Anatomy

## File Structure

```
VisualStudioChatExtension/
├── Properties/
├── References/
├── Commands/
├── Resources/
├── VisualStudioChatExtensionPackage.cs
├── source.extension.vsixmanifest
└── VSCommandTable.vsct
```

- `.vsixmanifest` (required)
    - Main file, contains information about the extension.
    - All components must be registered here.

- `VSCommandTable.vsct` 
    - Used to declare the commands, contains definitions about button commands, menus, keyboard shortcut bindings...

- `VisualStudioChatExtensionPackage.cs`
    - Entry point for most extensions.
    - Command Handlers, tool windows, options pages, services and any other components are registered here.
