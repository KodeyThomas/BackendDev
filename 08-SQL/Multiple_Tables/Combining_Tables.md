# Combining Tables

Let's say we have data spread across two tables, this kind of matching is called joining two tables

If we want to combine orders and customers, we would type:

```sql
SELECT * FROM orders JOIN customers ON orders.customer_id = customers.customer_id;
```

Let’s break down this command:

- The first line selects all columns from our combined table. If we only want to select certain columns, we can specify which ones we want.
- The second line specifies the first table that we want to look in, orders
- The third line uses JOIN to say that we want to combine information from orders with customers.
- The fourth line tells us how to combine the two tables. We want to match orders table’s customer_id column with customers table’s customer_id column.

Because column names are often repeated across multiple tables, we use the syntax table_name.column_name to be sure that our requests for columns are unambiguous. In our example, we use this syntax in the ON statement, but we will also use it in the SELECT or any other statement where we refer to column names.

For example: Instead of selecting all the columns using *, if we only wanted to select orders table’s order_id column and customers table’s customer_name column, we could use the following query:

```sql
SELECT orders.order_id,
    customers.customer_name
FROM orders
JOIN customers
  ON orders.customer_id = customers.customer_id;
```

### Inner Joins

Imagine our customers table was out of date... however our orders table contains customer information that is up to date.

We can perform a JOIN (referred to as an inner join) our result only includes rows that match our ON condition 

### Left Joins

SQL lets us do this through a command called LEFT JOIN. A left join will keep all rows from the first table, regardless of whether there is a matching row in the second table.

### Primary Keys & Foreign Keys

Each table has a column which uniquely identifies each row of that table:

- order_id for orders
- subscription_id for subscriptions
- customer_id for customers

These special columns are called **primary keys**

Primary Keys have a few unique requirements,

- None of the values can be NULL
- Each value must be unique
- Each table can only have one primary key column

When the primary key for one table appears in a different table, it is called a foreign key.

### Cross Join

Sometimes, we just want to combine all rows of one table with another

### Union

Sometimes we just want to stack on dataset on top of the other. We can do that with the UNION operator

Let's say we have two tables and they have the same columns 

We can combine them with UNION

### With

If we want to combine two tables but one of the tables is the result of another calculation

