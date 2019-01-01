# EverydayClipping
![GUI](https://github.com/RainySummerLuo/EverydayClipping/raw/master/EverydayClipping.png)

## Database File
### KM2.dat
Kindle Mate: http://kmate.me<br/>
Sync with Kindle and access **KM2.dat** file (SQLite) under the Kindle Mate directory.<br/>
Recommended to view with [SQLite Expert](http://www.sqliteexpert.com/).
### Location
- Database: **KM2**
- Table: **clippings**

## Packages
- System.Data.SQLite: https://www.nuget.org/packages/System.Data.SQLite

## GUI
### Font
- [方正屏显雅宋_GBK](http://www.foundertype.com/index.php/FontInfo/index/id/402.html): Authorized for non-commercial use.

## Code Implementation
### Randomly select one record: 
```sql
  SELECT * FROM clippings ORDER BY random() LIMIT 1
```
### Full Code
```c#
  var cn = new SQLiteConnection(ConnStr);
  cn.Open();
  var cmd = cn.CreateCommand();
  cmd.CommandText = "SELECT * FROM clippings ORDER BY random() LIMIT 1";
  var sr = cmd.ExecuteReader();
  sr.Read();
  linkLabel1.Text = sr.GetString(1);
  sr.Close();
```
