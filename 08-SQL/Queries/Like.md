# Like

LIKE can be a useful operator when you want to compare similar values.

The movies table contains two films with similar titles, ‘Se7en’ and ‘Seven’.

How could we select all movies that start with ‘Se’ and end with ‘en’ and have exactly one character in the middle?

```sql
SELECT * FROM movies WHERE name LIKE 'Se_en';
```

- LIKE is a special operator used with the WHERE clause to search for a specific pattern in a column.

- name LIKE 'Se_en' is a condition evaluating the name column for a specific pattern.

- Se_en represents a pattern with a wildcard character.

The `_` means you can substitute any individual character here without breaking the pattern. The names Seven and Se7en both match this pattern.

The percentage sign % is another wildcard character that can be used with LIKE.

This statement below filters the result set to only include movies with names that begin with the letter ‘A’:

```sql
SELECT * 
FROM movies
WHERE name LIKE 'A%';
```

% is a wildcard character that matches zero or more missing letters in the pattern. For example:

- A% matches all movies with names that begin with letter ‘A’
- %a matches all movies that end with ‘a’

We can also use % both before and after a pattern:

```sql
SELECT * 
FROM movies 
WHERE name LIKE '%man%';
```

Here, any movie that contains the word ‘man’ in its name will be returned in the result.

LIKE is not case sensitive. ‘Batman’ and ‘Man of Steel’ will both appear in the result of the query above.