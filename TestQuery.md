``` 
CREATE TABLE Author(
  Id INT IDENTITY(1, 1) PRIMARY KEY,
  Name VARCHAR(250) NOT NULL,
  BookTitle VARCHAR(250) NOT NULL UNIQUE
);

CREATE TABLE BookSold(
  Id INT IDENTITY(1, 1) PRIMARY KEY,
  BookTitle VARCHAR(250) NOT NULL CONSTRAINT FK_AuthorBookSold REFERENCES Author(BookTitle),
  Store VARCHAR(250) NOT NULL,
  CopiesSold INT NOT NULL
);
```
``` 
INSERT INTO Author
VALUES
  ('Amish', 'Immortals of Meluha'),
  ('Amish', 'The Secret of the Nagas'),
  ('Amish', 'The Oath of the Vayuputras'),
  ('Ashwin Sanghi', 'The Rozabal Line'),
  ('Ashwin Sanghi', 'Chanakya''s Chant'),
  ('Ashwin Sanghi', 'The Krishna Key'),
  ('Arundhati Roy', 'The God of Small Things'),
  ('Arundhati Roy', 'The Ministry of Utmost Happiness');

INSERT INTO BookSold
VALUES
  ('Immortals of Meluha', 'Amazon', 30000),
  ('Immortals of Meluha', 'Flipkart', 10000),
  ('Immortals of Meluha', 'Kindle', 10000),
  ('The Secret of the Nagas', 'Amazon', 25000),
  ('The Secret of the Nagas', 'Flipkart', 15000),
  ('The Secret of the Nagas', 'Kindle', 10000),
  ('The Oath of the Vayuputras', 'Amazon', 20000),
  ('The Oath of the Vayuputras', 'Flipkart', 5000),
  ('The Oath of the Vayuputras', 'Kindle', 5000),
  ('The Rozabal Line', 'Amazon', 30000),
  ('The Rozabal Line', 'Flipkart', 20000),
  ('Chanakya''s Chant', 'Amazon', 20000),
  ('Chanakya''s Chant', 'Flipkart', 20000),
  ('The Krishna Key', 'Amazon', 30000),
  ('The Krishna Key', 'Flipkart', 30000),
  ('The God of Small Things', 'Amazon', 25000),
  ('The God of Small Things', 'Kindle', 5000),
  ('The Ministry of Utmost Happiness', 'Amazon', 15000),
  ('The Ministry of Utmost Happiness', 'Kindle', 4000);
```
``` status
27 rows affected
```
``` 
SELECT * FROM Author;
```
| Id | Name | BookTitle |
| --:|:----|:---------|
| 1 | Amish | Immortals of Meluha |
| 2 | Amish | The Secret of the Nagas |
| 3 | Amish | The Oath of the Vayuputras |
| 4 | Ashwin Sanghi | The Rozabal Line |
| 5 | Ashwin Sanghi | Chanakya's Chant |
| 6 | Ashwin Sanghi | The Krishna Key |
| 7 | Arundhati Roy | The God of Small Things |
| 8 | Arundhati Roy | The Ministry of Utmost Happiness |

``` 
SELECT * FROM BookSold;
```
| Id | BookTitle | Store | CopiesSold |
| --:|:---------|:-----|----------:|
| 1 | Immortals of Meluha | Amazon | 30000 |
| 2 | Immortals of Meluha | Flipkart | 10000 |
| 3 | Immortals of Meluha | Kindle | 10000 |
| 4 | The Secret of the Nagas | Amazon | 25000 |
| 5 | The Secret of the Nagas | Flipkart | 15000 |
| 6 | The Secret of the Nagas | Kindle | 10000 |
| 7 | The Oath of the Vayuputras | Amazon | 20000 |
| 8 | The Oath of the Vayuputras | Flipkart | 5000 |
| 9 | The Oath of the Vayuputras | Kindle | 5000 |
| 10 | The Rozabal Line | Amazon | 30000 |
| 11 | The Rozabal Line | Flipkart | 20000 |
| 12 | Chanakya's Chant | Amazon | 20000 |
| 13 | Chanakya's Chant | Flipkart | 20000 |
| 14 | The Krishna Key | Amazon | 30000 |
| 15 | The Krishna Key | Flipkart | 30000 |
| 16 | The God of Small Things | Amazon | 25000 |
| 17 | The God of Small Things | Kindle | 5000 |
| 18 | The Ministry of Utmost Happiness | Amazon | 15000 |
| 19 | The Ministry of Utmost Happiness | Kindle | 4000 |

``` 
SELECT
  a.Name AS Author,
  a.BookTitle AS Book,
  SUM(bs.CopiesSold) AS TotalCopiesSold
FROM
  Author AS a
JOIN
  BookSold AS bs
ON
  a.BookTitle = bs.BookTitle
GROUP BY
  a.Name, a.BookTitle
ORDER BY
  TotalCopiesSold DESC;
```
| Author | Book | TotalCopiesSold |
| :------|:----|---------------:|
| Ashwin Sanghi | The Krishna Key | 60000 |
| Amish | Immortals of Meluha | 50000 |
| Amish | The Secret of the Nagas | 50000 |
| Ashwin Sanghi | The Rozabal Line | 50000 |
| Ashwin Sanghi | Chanakya's Chant | 40000 |
| Amish | The Oath of the Vayuputras | 30000 |
| Arundhati Roy | The God of Small Things | 30000 |
| Arundhati Roy | The Ministry of Utmost Happiness | 19000 |

``` 
SELECT
  a.Name AS Author,
  SUM(bs.CopiesSold) AS BooksSold
FROM
  Author AS a
JOIN
  BookSold AS bs
ON
  a.BookTitle = bs.BookTitle
GROUP BY
  a.Name
ORDER BY
  BooksSold DESC;
```
| Author | BooksSold |
| :------|---------:|
| Ashwin Sanghi | 150000 |
| Amish | 130000 |
| Arundhati Roy | 49000 |

``` 
SELECT
  TOP 1
  a.Name AS BestSellerAuthor
FROM
  Author AS a
JOIN
  BookSold AS bs
ON
  a.BookTitle = bs.BookTitle
GROUP BY
  a.Name
ORDER BY
  SUM(bs.CopiesSold) DESC;
```
| BestSellerAuthor |
| :----------------|
| Ashwin Sanghi |

[fiddle](https://dbfiddle.uk/z8Ktlsmc)
