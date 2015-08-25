<?php
         require_once '../config.php';
         define('dbhost', $_SC['dbhost']);
         define('dbuser', $_SC['dbuser']);
         define('dbpw', $_SC['dbpw']);
         define('dbname', $_SC['dbname']);
         define('pconnect', $_SC['pconnect']);
         define('dbcharset', $_SC['dbcharset']);
         define('charset', $_SC['charset']);
         define('tablepre', $_SC['tablepre']);
        
         function saveDoing($im, $msg)
        {
             $msg = $msg . " <font style=\"font-family:tahoma;font-weight:bold;font-size:10px;color:#999999\">FROM QQ</font>";
             $db_uch = new dbstuff();
             $db_uch -> charset = dbcharset;
             $db_uch -> connect(dbhost, dbuser, dbpw, dbname, pconnect);
             $uid = $db_uch -> result($db_uch -> query("SELECT uid FROM " . tname("spacefield") . " WHERE qq='{$im}'"), 0);
            
             if ($uid > 0)
            {
                 $uname = $db_uch -> result($db_uch -> query("SELECT username FROM " . tname("member") . " WHERE uid={$uid}"), 0);
                 update_doing($db_uch, $uid, $uname, $msg);
                 return "1";
                 }
            else
                {
                 return "0";
                 }
             $db_uch -> close();
            }
        
        function getImByName($uname)
        {
             $db_uch = new dbstuff();
             $db_uch -> charset = dbcharset;
             $db_uch -> connect(dbhost, dbuser, dbpw, dbname, pconnect);
             $uim = $db_uch -> result($db_uch -> query("SELECT qq FROM " . tname("spacefield") . " s," . tname("member") . " m WHERE s.uid=m.uid and m.username='{$uname}'"), 0);
             if(empty($uim))
                {
                 return "0";
                 }
            else
                {
                 return $uim;
                 }
             $db_uch -> close();
            }
        
        function getNameByIm($im)
        {
             $db_uch = new dbstuff();
             $db_uch -> charset = dbcharset;
             $db_uch -> connect(dbhost, dbuser, dbpw, dbname, pconnect);
             $imname = $db_uch -> result($db_uch -> query("SELECT username FROM " . tname("spacefield") . " s," . tname("member") . " m WHERE s.uid=m.uid and s.qq='{$im}'"), 0);
             if(empty($imname))
                {
                 return "0";
                 }
            else
                {
                 return $imname;
                 }
             $db_uch -> close();
            }
        
        function getImList($offset)
        {
             $db_uch = new dbstuff();
             $db_uch -> charset = dbcharset;
             $db_uch -> connect(dbhost, dbuser, dbpw, dbname, pconnect);
             $query = $db_uch -> query("SELECT qq FROM " . tname("spacefield") . " WHERE qq <> '' LIMIT " . $offset . ",50");
             while ($row = $db_uch -> fetch_array($query))
            {
                 if(!empty($row["qq"]))
                    {
                     if(empty($result))
                        {
                         $result = $row["qq"];
                         }
                    else
                        {
                         $result .= "," . $row["qq"];
                         }
                     }
                 }
             return $result;
            }
        
        function getImCount()
        {
             $db_uch = new dbstuff();
             $db_uch -> charset = dbcharset;
             $db_uch -> connect(dbhost, dbuser, dbpw, dbname, pconnect);
             $result = $db_uch -> result($db_uch -> query("SELECT COUNT(*) FROM " . tname("spacefield") . " WHERE qq <> ''"), 0);
             return $result;
            }
        
        function update_doing($db_uch, $uid, $uname, $msg)
        {
             $mtime = explode(' ', microtime());
             $doingarr = array(
                "uid" => $uid,
                 "username" => $uname,
                 "dateline" => $mtime[1],
                 "message" => $msg,
                 "ip" => "IM"
                );
             inserttable($db_uch, "doing", $doingarr, 1);
            
             updatetable($db_uch, "spacefield", array(
                    "note" => $uname
                    ), array(
                    "uid" => $uid
                    ));
            
             $feedarr = array(
                "appid" => 1,
                 "icon" => "doing",
                 "uid" => $uid,
                 "username" => $uname,
                 "dateline" => $mtime[1],
                 "title_template" => "{actor}:{message}",
                 "body_template" => "",
                 "body_general" => "",
                 "image_1" => "",
                 "image_1_link" => "",
                 "image_2" => "",
                 "image_2_link" => "",
                 "image_3" => "",
                 "image_3_link" => "",
                 "image_4" => "",
                 "image_4_link" => "",
                 "target_ids" => "",
                 "friend" => ""
                );
             $feedarr = sstripslashes($feedarr);
             $feedarr['title_data'] = serialize(sstripslashes(array("message" => $msg)));
             $feedarr['body_data'] = serialize(sstripslashes(array()));
             $feedarr['hash_template'] = md5($feedarr['title_template'] . "\t" . $feedarr['body_template']);
             $feedarr['hash_data'] = md5($feedarr['title_template'] . "\t" . $feedarr['title_data'] . "\t" . $feedarr['body_template'] . "\t" . $feedarr['body_data']);
             $feedarr = sstripslashes($feedarr);
             inserttable($db_uch, "feed", $feedarr);
            }
        
        function tname($name)
        {
             return tablepre . $name;
            }
        
        function sstripslashes($string)
        {
             if (is_array($string))
                {
                 foreach ($string as $key => $val)
                {
                     $string[$key] = sstripslashes($val);
                     }
                 }
            else
                {
                 $string = stripslashes($string);
                 }
             return $string;
            }
        
        function inserttable($db, $tablename, $insertsqlarr, $returnid = 0, $replace = false)
        {
             $insertkeysql = $insertvaluesql = $comma = "";
             foreach ($insertsqlarr as $insert_key => $insert_value)
            {
                 $insertkeysql .= $comma . "`" . $insert_key . "`";
                 $insertvaluesql .= $comma . "'" . $insert_value . "'";
                 $comma = ", ";
                 }
             $method = $replace ? "REPLACE" : "INSERT";
             $db -> query($method . " INTO " . tname($tablename) . " (" . $insertkeysql . ") VALUES (" . $insertvaluesql . ") ");
             if ($returnid && !$replace)
            {
                 return $db -> insert_id();
                 }
            }
        
        function updatetable($db, $tablename, $setsqlarr, $wheresqlarr)
        {
             $setsql = $comma = "";
             foreach ($setsqlarr as $set_key => $set_value)
            {
                 $setsql .= $comma . "`" . $set_key . "`" . "='" . $set_value . "'";
                 $comma = ", ";
                 }
             $where = $comma = "";
             if (empty($wheresqlarr))
                {
                 $where = "1";
                 }
            else if (is_array($wheresqlarr))
                {
                 foreach ($wheresqlarr as $key => $value)
                {
                     $where .= $comma . "`" . $key . "`" . "='" . $value . "'";
                     $comma = " AND ";
                     }
                 }
            else
                {
                 $where = $wheresqlarr;
                 }
             $db -> query("UPDATE " . tname($tablename) . " SET " . $setsql . " WHERE " . $where);
            }
        
        class dbstuff
        {
             var $querynum = 0;
             var $link;
             var $charset;
            
             function connect($dbhost, $dbuser, $dbpw, $dbname = "", $pconnect = 0, $halt = TRUE)
            {
                 if ($pconnect)
                {
                     if (!($this -> link = @mysql_pconnect($dbhost, $dbuser, $dbpw)))
                        {
                         if ($halt)
                        {
                             $this -> halt("Can not connect to MySQL server");
                             }
                         }
                     }
                else if (!($this -> link = @mysql_connect($dbhost, $dbuser, $dbpw)))
                    {
                     if ($halt)
                    {
                         $this -> halt("Can not connect to MySQL server");
                         }
                     }
                 if ("4.1" < $this -> version())
                    {
                     if ($this -> charset)
                    {
                         @mysql_query("SET character_set_connection={$this->charset}, character_set_results={$this->charset}, character_set_client=binary", $this -> link);
                         }
                     if ("5.0.1" < $this -> version())
                        {
                         @mysql_query("SET sql_mode=''", $this -> link);
                         }
                     }
                 if ($dbname)
                {
                     @mysql_select_db($dbname, $this -> link);
                     }
                 }
            
             function select_db($dbname)
            {
                 return mysql_select_db($dbname, $this -> link);
                 }
            
             function fetch_array($query, $result_type = MYSQL_ASSOC)
            {
                 return mysql_fetch_array($query, $result_type);
                 }
            
             function query($sql, $type = "")
            {
                 $func = $type == "UNBUFFERED" && @function_exists("mysql_unbuffered_query") ? "mysql_unbuffered_query" : "mysql_query";
                 if (!($query = $func($sql, $this -> link)) && $type != "SILENT")
                    {
                     $this -> halt("MySQL Query Error", $sql);
                     }
                 ++$this -> querynum;
                 return $query;
                 }
            
             function affected_rows()
            {
                 return mysql_affected_rows($this -> link);
                 }
            
             function error()
            {
                 return $this -> link ? mysql_error($this -> link) : mysql_error();
                 }
            
             function errno()
            {
                 return intval($this -> link ? mysql_errno($this -> link) : mysql_errno());
                 }
            
             function result($query, $row)
            {
                 $query = @mysql_result($query, $row);
                 return $query;
                 }
            
             function num_rows($query)
            {
                 $query = mysql_num_rows($query);
                 return $query;
                 }
            
             function num_fields($query)
            {
                 return mysql_num_fields($query);
                 }
            
             function free_result($query)
            {
                 return mysql_free_result($query);
                 }
            
             function insert_id()
            {
                 return 0 <= ($id = mysql_insert_id($this -> link)) ? $id : $this -> result($this -> query("SELECT last_insert_id()"), 0);
                 }
            
             function fetch_row($query)
            {
                 $query = mysql_fetch_row($query);
                 return $query;
                 }
            
             function fetch_fields($query)
            {
                 return mysql_fetch_field($query);
                 }
            
             function version()
            {
                 return mysql_get_server_info($this -> link);
                 }
            
             function close()
            {
                 return mysql_close($this -> link);
                 }
            
             function halt($message = "", $sql = "")
            {
                 echo "<div style=\"position:absolute;font-size:11px;font-family:verdana,arial;background:#EBEBEB;padding:0.5em;\">\r\n\t\t\t\t<b>MySQL Error</b><br>\r\n\t\t\t\tMessage: {$message}<br>\r\n\t\t\t\tSQL: {$sql}<br>\r\n\t\t\t\tError: " . $this -> error() . "<br>\r\n\t\t\t\tErrno.: " . $this -> errno() . "</div>";
                 exit();
                 }
            
            }
        
        require_once("rpc/phprpc_server.php");
        $server = new PHPRPC_Server();
        $server -> add("saveDoing");
        $server -> add("getImByName");
        $server -> add("getNameByIm");
        $server -> add("getImList");
        $server -> add("getImCount");
        $server -> start();
?>