<?php

require_once 'BaseEntity.php';

/**
 * Class CheckCountRequest is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class CheckCountRequest
 */
class CheckCountRequest extends BaseEntity {

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

    function __constructor() {
        
    }

    public static function createAll($agentcode, $catecode, $amount) {
        $instance = new self();
        $instance->setAgentcode($agentcode);
        $instance->setCatecode($catecode);
        $instance->setAmount($amount);
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
