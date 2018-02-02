# Functional

> Functional library for C#

## Example

### Currying

```csharp
Func<int, int, int, int> Add = (a, b, c) => a + b + c;
var add = Add.Curried();
var maybe_six = add(1)(2)(3);
```