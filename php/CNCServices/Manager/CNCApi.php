<?php

include_once 'Entities/BuyCardRequest.php';
include_once 'Entities/CheckCountRequest.php';
include_once 'Entities/CheckCountResponse.php';
include_once 'Entities/GetCardRequest.php';
include_once 'Entities/ResponseRequest.php';
include_once 'Entities/ResponseRequestCheckCount.php';
include_once 'Entities/ResponseTopup.php';
include_once 'Entities/TopupRequest.php';
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

    /* Process Call BuyCard Function */

    public function BuyCard() {
        $strReturn = "";
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranid = date("YmdHis");
        $bcr = BuyCardRequest::createAll($txtAgentCode, "VT", $tranid, 10000, 2);
        $bcrString = $bcr->toJson();
        $rr = new ResponseRequest();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $bcrString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("BuyCard", $params)['BuyCardResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rr->set($data);
            if ($rr->getCode() == 1) {
                $listResult = Util::Decrypt($txtAgentKey, $rr->getListCards());
                $rr->setListCards($listResult);
            } else {
                $rr->setListCards("");
            }
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rr->toJson();
    }

    /* Process call GetCard function */

    public function GetCard() {
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranidRequest = "2016062711420056";
        $gcr = GetCardRequest::createAll($txtAgentCode, $tranidRequest);
        $gcrString = $gcr->toJson();
        $rr = new ResponseRequest();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $gcrString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("GetCard", $params)['GetCardResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rr->set($data);
            if ($rr->getCode() == 1) {
                $listResult = Util::Decrypt($txtAgentKey, $rr->getListCards());
                $rr->setListCards($listResult);
            } else {
                $rr->setListCards("");
            }
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rr->toJson();
    }

    /*
     * Demo Call Topup Serivce
     */

    public function Topup() {
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranidRequest = "2016062711420056";
        $tr = TopupRequest::createAll($txtAgentCode, "VT", $tranidRequest, "0902183903", 10000);
        $trString = $tr->toJson();
        $rt = new ResponseTopup();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $trString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("Topup", $params)['TopupResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rt->set($data);
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rt->toJson();
    }

    /*
     * Demo Call Check Transaction Topup Service
     */

    public function CheckTranTopup() {
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $tranidRequest = "2016062711420056";
        $gcr = GetCardRequest::createAll($txtAgentCode, $tranidRequest);
        $gcrString = $gcr->toJson();
        $rt = new ResponseTopup();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $gcrString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentCode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("CheckTranTopup", $params)['CheckTranTopupResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $rt->set($data);
        } catch (Exception $exc) {
            die($exc->getMessage());
        }
        return $rt->toJson();
    }

    /*
     * Demo Call Check Count Service
     */

    public function CheckCount() {
        $txtData = "";
        $txtAgentCode = Util::$agentCode;
        $txtAgentKey = Util::$agentKey;
        $ccrequest = CheckCountRequest::createAll($txtAgentCode, "VT", 10000);
        $ccRequestString = $ccrequest->toJson();
        $ccResponse = new CheckCountResponse();
        try {
            $txtData = Util::Encrypt($txtAgentKey, $ccRequestString);
            $client = new SoapClient(Util::$cncServiceUrl, true);
            $params = array('agentcode' => $txtAgentCode, 'data' => $txtData);
            $result = $client->call("CheckCount", $params)['CheckCountResult'];
            $error = $client->getError();
            if ($error) {
                print_r($client->response);
                print_r($client->getDebug());
                die();
            }
            $json = utf8_decode($result);
            $data = json_decode($json, true);
            $ccResponse->set($data);
            if ($ccResponse->getCode() == 1) {
                $listResult = Util::Decrypt($txtAgentKey, $ccResponse->getListprovider());
                $ccResponse->setListprovider($listResult);
                $dataTmp = json_decode($listResult, true);
                $ccResponse->set($dataTmp);
            } else {
                $ccResponse->setListprovider("");
            }
        } catch (Exception $exc) {
            $ccResponse->setListprovider("");
        }
        return $ccResponse->toJson();
    }

}
