.Net is the entire ecosystem surround C# programs.

.Net includes

- Runetime - Enviroment C# runs in
- Base Class Library - Code that is already written to use
- Software Development Kit - .Net is shared with Visual Basic, F#, and PowerShell
- 
- Hierarchial Organization - Code elements that live inside other code elements. Use the "dot operator" . to access a classes methods.
- Code Map - used to describe hierarchale organization
- Base Class Library
    - System
        - Console
            - WriteLine
        - Convert
            - ToInt32
        - Math
            - Max

Type Interface - Infering the type of a variable based on value assiged.

```c#
var message = "hello" // message is a string
```

You can limit the amount of numeral output from an expression by putting a colon : in the string interputation then a format string.

'0' inidcates you want a number in that location. If there is not a number, it will place a zero "0"

```c#
Math.PI: 0.000 => 3.141
```

'#' indicates you want a to leave a space but if there is no number, it will not leave a zero.

```c#
42: #.## => 42
```

'%' can be used to represent a percent

```c#
$"Percentage of people {num%people}:0.0%" => Percentage of people 3.3%
```

Ternary Operator - Allows you to do a conditional check on one line.

```c#
conditionalExpression ? expression if true : expression if false;
string displayText = score>70 ? "Winner!" : "Loser!";
```

