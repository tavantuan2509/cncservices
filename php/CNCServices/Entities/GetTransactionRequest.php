<?php

require_once 'BaseEntity.php';

/**
 * Class GetTransactionRequest is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class GetTransactionRequest
 */
class GetTransactionRequest extends BaseEntity {

    /**
     * mã đối tác
     */
    private $agentcode;

    /**
     * Mã giao dịch đối tác
     */
    private $tranid;

    function __constructor() {
        
    }

    public static function createAll($agentcode, $tranid) {
        $instance = new self();
        $instance->setAgentcode($agentcode);
        $instance->setTranid($tranid);
        return $instance;
    }

    public function getAgentcode() {
        return $this->agentcode;
    }

    public function setAgentcode($agentcode) {
        $this->agentcode = $agentcode;
    }

    public function getTranid() {
        return $this->tranid;
    }

    public function setTranid($tranid) {
        $this->tranid = $tranid;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
