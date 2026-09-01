# Token

## What?

- A token is the **smallest meaningful unit** of a C# program that the compiler can understand.

## Kinds of Token?

- **[Keywords](./ref.keywords.md)**
  - **Reserved words** with a **special meaning** in C#.
  - Generally written in **lowercase**.
  - Cannot normally be used as identifiers.
- **Operators**
  - `+` `-` `*` `/` `%` `<` `!=` `=` `==` `.`
  - `.` is **member access operator**
- **Literals**: Fixed values
  - Integer Literals: 2
  - Floating-point Literals: 3.43
  - Character Literals: ''
  - String Literals: ""
  - Boolean Literals: `true`, `false`
  - Null Literals: `null`
- **Identifiers**:
  - User defined Names (Variable, class, field, property name)
  - Predefined Names (`System`, `Console`, `WriteLine`)
- **Punctuation** / **Delimiters**
  - `;` Statement Terminator
  - `,` Separator
  - `(` `)` `{` `}` `[` `]` Delimiters

## Rule

- Token != Character. `>=` 2 characters but one token. `Console.WriteLine` 3 token
