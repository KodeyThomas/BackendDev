# Distinct

When we are examining data in a table, it can be helpful to know what distinct values exist in a particular column.

DISTINCT is used to return unique values in the output. It filters out all duplicate values in the specified column(s).

```sql
SELECT tools FROM inventory;
```

By adding `Distinct` before the column name, we can filter the results to give us unique values in a column