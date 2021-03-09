SELECT * FROM nomnom;

SELECT DISTINCT neighborhood FROM nomnom;

SELECT DISTINCT cuisine FROM nomnom;

SELECT * FROM nomnom WHERE cuisine = 'Chinese';

SELECT restaurants FROM nomnom WHERE review >= 4;

SELECT restaurants FROM nomnom WHERE cuisine = 'Italian' AND price = '$$$';

SELECT restaurants FROM nomnom WHERE name = '%meatball%';

SELECT * FROM nomnom WHERE neighborhood = 'Midtown' OR 'Downtown' OR 'Chinatown';

SELECT restaurants FROM nomnom WHERE health IS NULL;

SELECT * FROM nomnom ORDER BY review DESC LIMIT 10;

SELECT name,
 CASE
  WHEN review > 4.5 THEN 'Extraordinary'
  WHEN review > 4 THEN 'Excellent'
  WHEN review > 3 THEN 'Good'
  WHEN review > 2 THEN 'Fair'
  ELSE 'Poor'
 END AS 'Review'
FROM nomnom;