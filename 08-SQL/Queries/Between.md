# Between

The BETWEEN operator is used in a WHERE clause to filter the result set within a certain range. It accepts two values that are either numbers, text or dates.

For example, this statement filters the result set to only include movies with years from 1990 up to, and including 1999.

```sql
SELECT * FROM movies WHERE year BETWEEN 1990 AND 1999;
```
> When the values are text, BETWEEN filters the result set for within the alphabetical range

In this statement, BETWEEN filters the result set to only include movies with names that begin with the letter ‘A’ up to, but not including ones that begin with ‘J’.

```sql
SELECT * FROM movies WHERE name BETWEEN 'A' AND 'J';
```