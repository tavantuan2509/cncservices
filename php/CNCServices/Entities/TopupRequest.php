<?php

require_once 'BaseEntity.php';

/**
 * Class TopupRequest is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class TopupRequest
 */
class TopupRequest extends BaseEntity {

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
     * Số điện thoại
     */
    private $target;

    /**
     * Mệnh giá
     */
    private $amount;

    /**
     * Mã dịch vụ
     */
    private $type;

    function __constructor() {
        
    }

    public static function createAll($agentcode, $catecode, $tranid, $target, $amount, $type) {
        $instance = new self();
        $instance->setAgentcode($agentcode);
        $instance->setAmount($amount);
        $instance->setCatecode($catecode);
        $instance->setTarget($target);
        $instance->setTranid($tranid);
        $instance->setType($type);
        return $instance;
    }

    public function getType() {
        return $this->type;
    }

    public function setType($type) {
        $this->type = $type;
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

    public function getTarget() {
        return $this->target;
    }

    public function setTarget($target) {
        $this->target = $target;
    }

    public function getAmount() {
        return $this->amount;
    }

    public function setAmount($amount) {
        $this->amount = $amount;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
