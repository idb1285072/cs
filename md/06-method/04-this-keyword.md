# `this` Keyword
## What
- `this` = **current object**
- available only within the instance method (non-static method)
- if parameter and field name are same, then use `this` keyword is required. Otherwise, optional

## Example

```cs
public class Product
{
    private int id;
    private string name;
    private decimal cost;

    // set method for productId
    public void SetProductId(int id)
    {
        this.id = id; // this is required
    }

    // get method for productId
    public int GetProductId()
    {
        return this.id; // this is Optional
    }
}
```
