CREATE OR REPLACE VIEW schema_tables AS
SELECT   o.object_type AS object_type
,        c.table_name AS table_name
,        c.column_id AS column_id
,        c.column_name AS column_name
,        DECODE(c.nullable,'N','NOT NULL','') AS nullable
,        DECODE(c.data_type
,          'BFILE'        ,'BINARY FILE LOB'
,          'BINARY_FLOAT' ,c.data_type
,          'BINARY_DOUBLE',c.data_type
,          'BLOB'         ,c.data_type
,          'CLOB'         ,c.data_type
,          'CHAR'         ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'DATE'         ,c.data_type
,          'FLOAT'        ,c.data_type
,          'LONG RAW'     ,c.data_type
,          'NCHAR'        ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'NVARCHAR2'    ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'NUMBER'       ,DECODE(NVL(c.data_precision||c.data_scale,0)
,        0,c.data_type
,        DECODE(NVL(c.data_scale,0),0
,        c.data_type||'('||c.data_precision||')'
,        c.data_type||'('||c.data_precision||','|| c.data_scale||')'))
,          'RAW'          ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'VARCHAR'      ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'VARCHAR2'     ,DECODE(NVL(c.data_length,0),0,c.data_type
,        c.data_type||'('||c.data_length||')')
,          'TIMESTAMP'     , c.data_type,c.data_type) AS data_type
,        CASE WHEN c.data_default IS NULL THEN 'N' ELSE 'Y' END AS data_default
FROM     user_tab_columns c,user_objects o
WHERE    o.object_name = c.table_name
ORDER BY c.table_name, c.column_id
/
set feed off markup html on spool on
/
spool 'c:\filename.htm'
/
select * from schema_tables
/
spool off
/
set markup html off spool off
/
