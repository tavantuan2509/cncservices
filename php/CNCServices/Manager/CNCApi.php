<?php

include_once 'Entities/GetTransactionRequest.php';
include_once 'Entities/ResponseUseCard.php';
include_once 'Entities/UseCard.php';
include_once 'lib/nusoap.php';
include_once 'Util/Util.php';

/**
 * Class CNCApi is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class CNCApi
 */
class CNCApi {

    function __construct() {
        
    }

    /* Process Call UseCard Function */

    public function UseCard() {
        $strReturn = "";
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranid = date("YmdHis");
        $bcr = UseCard::createAll($txtAgentCode, "VT", $tranid, "cardcode", "card serial");
        $bcrString = $bcr->toJson();
        $rr = new ResponseUseCard();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $bcrString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("UseCard", $params)['UseCardResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rr->set($data);
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rr->toJson();
    }

    /* Process call GetTransaction function */

    public function GetTransaction() {
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranidRequest = "2016062711420056";
        $gcr = GetTransactionRequest::createAll($txtAgentCode, $tranidRequest);
        $gcrString = $gcr->toJson();
        $rr = new ResponseUseCard();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $gcrString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("GetTransaction", $params)['GetTransactionResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rr->set($data);
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rr->toJson();
    }

}
