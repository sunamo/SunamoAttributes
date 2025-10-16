# NuGet Alternatives to SunamoAttributes

This document lists popular NuGet packages that provide similar functionality to SunamoAttributes.

## Overview

Custom attributes and attribute-related utilities

## Alternative Packages

### System.Reflection
- **NuGet**: System.Reflection
- **Purpose**: Built-in .NET reflection capabilities
- **Key Features**: Attribute reading, type inspection, metadata access

### Fody
- **NuGet**: Fody
- **Purpose**: IL weaving tool for code generation via attributes
- **Key Features**: Compile-time code injection, property change notification

### PostSharp
- **NuGet**: PostSharp
- **Purpose**: Aspect-oriented programming with attributes
- **Key Features**: Cross-cutting concerns, caching, logging via attributes

## Comparison Notes

Most attribute functionality is available in System.Reflection. Fody/PostSharp add compile-time capabilities.

## Choosing an Alternative

Consider these alternatives based on your specific needs:
- **System.Reflection**: Built-in .NET reflection capabilities
- **Fody**: IL weaving tool for code generation via attributes
- **PostSharp**: Aspect-oriented programming with attributes
