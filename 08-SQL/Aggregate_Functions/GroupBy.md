# Group By

Oftentimes, we will want to calculate an aggregate for data with certain characteristics.

For instance, we might want to know the mean IMDb ratings for all movies each year. We could calculate each number by a series of queries with different WHERE statements, like so:

```sql
SELECT AVG(imdb_rating)
FROM movies
WHERE year = 1999;
 
SELECT AVG(imdb_rating)
FROM movies
WHERE year = 2000;
 
SELECT AVG(imdb_rating)
FROM movies
WHERE year = 2001;
```

Luckily, there’s a better way!

We can use GROUP BY to do this in a single step:

```sql
SELECT year,
   AVG(imdb_rating)
FROM movies
GROUP BY year
ORDER BY year;
```

GROUP BY is a clause in SQL that is used with aggregate functions. It is used in collaboration with the SELECT statement to arrange identical data into groups.

> The GROUP BY statement comes after any WHERE statements, but before ORDER BY or LIMIT.

Sometimes, we want to GROUP BY a calculation done on a column.

For instance, we might want to know how many movies have IMDb ratings that round to 1, 2, 3, 4, 5. We could do this using the following syntax:

```sql
SELECT ROUND(imdb_rating),
   COUNT(name)
FROM movies
GROUP BY ROUND(imdb_rating)
ORDER BY ROUND(imdb_rating);
```

However, this query may be time-consuming to write and more prone to error.

SQL lets us use column reference(s) in our GROUP BY that will make our lives easier.

- 1 is the first column selected
- 2 is the second column selected
- 3 is the third column selected

and so on.

The following query is equivalent to the one above:

```sql
SELECT ROUND(imdb_rating),
   COUNT(name)
FROM movies
GROUP BY 1
ORDER BY 1;
```

Here, the 1 refers to the first column in our SELECT statement, ROUND(imdb_rating).