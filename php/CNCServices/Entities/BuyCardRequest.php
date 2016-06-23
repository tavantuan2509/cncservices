<?php

require_once 'BaseEntity.php';

/**
 * Class BuyCardRequest is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class BuyCardRequest
 */
class BuyCardRequest extends BaseEntity {

    /**
     * mã đối tác
     */
    private $agentcode;

    /**
     * Mã đơn vị phát hành thẻ
     */
    private $catecode;

    /**
     * Mệnh giá
     */
    private $amount;

    /**
     * Số lượng
     */
    private $quantity;

    /**
     * Mã giao dịch đối tác
     */
    private $tranid;

    function __constructor() {
        
    }

    public static function createAll($agentcode, $catecode, $tranid, $amount, $quantity) {
        $instance = new self();
        $instance->setAgentcode($agentcode);
        $instance->setCatecode($catecode);
        $instance->setTranid($tranid);
        $instance->setAmount($amount);
        $instance->setQuantity($quantity);
        return $instance;
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

    public function getAmount() {
        return $this->amount;
    }

    public function setAmount($amount) {
        $this->amount = $amount;
    }

    public function getQuantity() {
        return $this->quantity;
    }

    public function setQuantity($quantity) {
        $this->quantity = $quantity;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
