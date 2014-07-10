--http://www.cnblogs.com/lyhabc/p/3828496.html
--计算数据库中各个表的数据量很每行记录所占用空间

CREATE TABLE #tablespaceinfo
    (
      nameinfo VARCHAR(50) ,
      rowsinfo BIGINT ,
      reserved VARCHAR(20) ,
      datainfo VARCHAR(20) ,
      index_size VARCHAR(20) ,
      unused VARCHAR(20)
    )  
 
DECLARE @tablename VARCHAR(255);  
 
DECLARE Info_cursor CURSOR
FOR
    SELECT  '[' + [name] + ']'
    FROM    sys.tables
    WHERE   type = 'U';  
 
OPEN Info_cursor  
FETCH NEXT FROM Info_cursor INTO @tablename  
 
WHILE @@FETCH_STATUS = 0
    BEGIN 
        INSERT  INTO #tablespaceinfo
                EXEC sp_spaceused @tablename  
        FETCH NEXT FROM Info_cursor  
    INTO @tablename  
    END 
 
CLOSE Info_cursor  
DEALLOCATE Info_cursor  
 
--创建临时表
CREATE TABLE [#tmptb]
    (
      TableName VARCHAR(50) ,
      DataInfo BIGINT ,
      RowsInfo BIGINT ,
      Spaceperrow AS ( CASE RowsInfo
                         WHEN 0 THEN 0
                         ELSE DataInfo / RowsInfo
                       END ) PERSISTED
    )

--插入数据到临时表
INSERT  INTO [#tmptb]
        ( [TableName] ,
          [DataInfo] ,
          [RowsInfo]
        )
        SELECT  [nameinfo] ,
                CAST(REPLACE([datainfo], 'KB', '') AS BIGINT) AS 'datainfo' ,
                [rowsinfo]
        FROM    #tablespaceinfo
        ORDER BY CAST(REPLACE(reserved, 'KB', '') AS INT) DESC  


--汇总记录
SELECT  [tbspinfo].* ,
        [tmptb].[Spaceperrow] AS '每行记录大概占用空间（KB）'
FROM    [#tablespaceinfo] AS tbspinfo ,
        [#tmptb] AS tmptb
WHERE   [tbspinfo].[nameinfo] = [tmptb].[TableName]
ORDER BY CAST(REPLACE([tbspinfo].[reserved], 'KB', '') AS INT) DESC  

DROP TABLE [#tablespaceinfo]
DROP TABLE [#tmptb]