# PrivateInfringer

This Library is meant to be helpful for testing or running private functions  of an object.

## Getting Started

- Download xxx.dll
- In Visual Studio add xxx.dll as dependency

## Example Code

In most of the cases test private method is not that productive since you call them in your public methods.

There are some scenarios especially working with legacy code where you might want to test/run private methods of an object.

If a private method has such relevance that needs to be tested, it's probably better to make it live in its own class.

By relevance I mean the length and the complexity, on the understanding that they should be as short and simple as possible.

