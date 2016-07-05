<?php

//phpinfo();
require_once 'Manager/CNCApi.php';
$cncApi = new CNCApi();
$result = $cncApi->UseCard();/*Call Get Card*/
$result = $cncApi->GetTransaction();/*Call GetTransaction*/
echo $result;
?>