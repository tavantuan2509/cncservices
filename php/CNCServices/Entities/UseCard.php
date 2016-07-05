<?php

require_once 'BaseEntity.php';

/**
 * Class UseCard is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class UseCard
 */
class UseCard extends BaseEntity {

    /**
     * mã đối tác
     */
    private $agentcode;

    /**
     * Mã đơn vị phát hành thẻ
     */
    private $catecode;

    /**
     * Mã giao dịch đối tác
     */
    private $tranid;

    /**
     * Mã thẻ
     */
    private $cardcode;

    /**
     * serial thẻ
     */
    private $cardserial;

    function __constructor() {
        
    }

    public static function createAll($agentcode, $catecode, $tranid, $cardcode, $cardserial) {
        $instance = new self();
        $instance->setAgentcode($agentcode);
        $instance->setCardCode($cardcode);
        $instance->setCatecode($catecode);
        $instance->setCardSerial($cardserial);
        $instance->setTranid($tranid);
        return $instance;
    }

    public function getCardCode() {
        return $this->cardcode;
    }

    public function setCardCode($cardcode) {
        $this->cardcode = $cardcode;
    }

    public function getAgentcode() {
        return $this->agentcode;
    }

    public function setAgentcode($agentcode) {
        $this->agentcode = $agentcode;
    }

    public function getCatecode() {
        return $this->catecode;
    }

    public function setCatecode($catecode) {
        $this->catecode = $catecode;
    }

    public function getTranid() {
        return $this->tranid;
    }

    public function setTranid($tranid) {
        $this->tranid = $tranid;
    }

    public function getCardSerial() {
        return $this->cardserial;
    }

    public function setCardSerial($cardserial) {
        $this->cardserial = $cardserial;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
