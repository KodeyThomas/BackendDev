# NULL

Unknown values are indicated by NULL.

It is not possible to test for NULL values with comparison operators, such as = and !=.

Instead, we will have to use these operators:

- IS NULL
- IS NOT NULL

To filter for all movies with an IMDb rating:

```sql
SELECT name FROM movies WHERE imdb_rating IS NOT NULL
```