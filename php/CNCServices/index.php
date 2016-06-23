<?php

//phpinfo();
require_once 'Manager/CNCApi.php';
$cncApi = new CNCApi();
//$result = $cncApi->BuyCard();/*Call Buy Card*/
//$result = $cncApi->GetCard();/*Call Get Card*/
//$result = $cncApi->Topup(); /* Call Get Card */
//$result = $cncApi->CheckTranTopup(); /* Call Get Card */
$result = $cncApi->CheckCount(); /* Call Get Card */
echo $result;
?>