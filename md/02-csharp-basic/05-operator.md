# Operators

## What?

- Operator is a symbol to perform operation.
- Operator receives one or more operands (values) and returns one value

## Classification

- **Arithmetical Operators**
  - `+` Addition
  - `-` Subtraction
  - `*` Multiplication
  - `/` Division
  - `%` Remainder
- **Assignment Operators**
  - `=` Assigns to
  - `+=` Add and Assigns to
  - `-=` Subtract and Assigns to
  - `*=` Multiply and Assigns to
  - `/=` Divide and Assigns to
  - `%=` Remainder Assigns to
- **Increment and Decrement Operators**
  - `n++` Post-Increment (First it returns value, then increments)
  - `++n` Pre-Increment (First it increments value, then returns)
  - `n--` Post-Decrement (First it returns value, then decrements)
  - `--n` Pre-Decrement (First it decrements value, then returns)
- **Comparison Operators**
  - compare two values and return `true` or `false`
  - `==` equal to
  - `!=` not equal to
  - `<` less than
  - `>` greater than
  - `<=` less than or equal to
  - `>=` greater than or equal to
- Logical Operators
  - Checks both operands (Boolean) and return `true` or `false`
  - `&` logical and
    - both operands should be `true`
    - evaluates both operands, even if left-hand operand returns `false`
  - `&&` conditional and
    - both operands should be true
    - doesn't evaluate right-hand operand, if left-hand operand return false
  - `|` logical or
    - at least any one operand should be `true`
    - evaluates both operand, even if left-hand operand returns `true`
  - `||` conditional or
    - at least any one operand should be `true`
    - doesn't evaluate right-hand operand, if left-hand operand `true`
  - `^` logical exclusive or - XOR
    - any one operand only should be `true`
    - evaluates both operands
  - `!` negation
    - `true` becomes `false`
    - `false` becomes `true`
- **Concatenation Operators**
  - `+` attach second operand string at the end of first operand string and returns the combined string
  - "string1" + "string2" returns "string1string2" (as string)
  - "string" + Number returns "stringNumber" (as string)
  - Number + "String" returns "NumberString" (as string)
- **Ternary Operators**
  - `?:` condition ? consequent : alternative
  - It evaluates the given boolean value
  - Return first expression (consequent) if `true`
  - Return second expression (alternative) if `false`

## Operator Precedence

- Postfix `()` `[]` `++` `--`
- Unary `+` `-` `!`
- Multiplicative `*` `/` `%`
- Additive `+` `-`
- Relational `<` `>` `<=` `>=`
- Equality `==` `!=`
- Logical AND `&&`
- Logical OR `||`
- Conditional `?:`
- Assignment `=` `+=` `-=` `*=` `/=` `%=`
  > Operations are evaluated based on the order of precedence.

> Highest precedence appear at the top.
