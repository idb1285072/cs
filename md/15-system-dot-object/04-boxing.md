# Boxing and Unboxing

## What

- **Boxing**:
  - Conversion from value-type to reference-type
  - This can be done automatically. (implicitly)
  - ```cs
    int x = 10;
    object obj = x;
    ```
- **Unboxing**:
  - Conversion from reference-type to value-type, if they are compatible data type
  - This should be done explicitly (by using explicit casting)
  - ```cs
    object obj = 10;
    int x = (int)obj;
    ```
