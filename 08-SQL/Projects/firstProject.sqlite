CREATE TABLE friends (
  id INTEGER,
  name TEXT,
  birthday DATE
);

INSERT INTO friends (id,name,birthday)
VALUES (1,"Ororo Munroe",'1940-05-30');

SELECT * FROM friends;

INSERT INTO friends (id,name,birthday)
VALUES (2, "Kodey Thomas", '2004-04-01');

INSERT INTO friends (id,name,birthday)
VALUES (3, "Test", "2000-01-01");

UPDATE friends
SET name = "Storm"
WHERE id = 1;

ALTER TABLE friends
ADD COLUMN email TEXT;

UPDATE friends
SET email = "kodeyjjthomas@gmail.com"
WHERE id = 2;

UPDATE friends
SET email = "storm@codecadmey.com"
WHERE id = 1;

UPDATE friends
SET email = "test@test.com"
WHERE id = 3;

DELETE FROM friends
WHERE email = "storm@codecadmey.com";

SELECT * FROM friends;