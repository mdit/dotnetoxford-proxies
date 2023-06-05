# dotnetoxford-proxies
Proxy Source Generator examples for .NET Oxford lightning talk in June 2023

## Introduction
This repository provides example code for my lightnihg talk at .NET Oxford on June 6th 2023.
It demonstrates how to use the [ProxyInterfaceGenerator](https://github.com/StefH/ProxyInterfaceSourceGenerator) C# Source Generator to create
Proxy and Interfaces for concrete types which can be used to aid testing and help abstract out third-party or native dependencies in a very easy way.

The commits in the repository are staged in order to introduce each concept at a time, starting with introducing a model of software engineering roles,
then introducing abstractions using the source generator and finally introducing services with native dependencies, and a demonstration of how to 
introduce a proxy interface and use it in a unit test for previously difficult to test behaviour such as displaying a message box using the native Windows user32.dll.
