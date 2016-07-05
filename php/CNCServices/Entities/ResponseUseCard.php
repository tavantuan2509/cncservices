<?php

require_once 'BaseEntity.php';

/**
 * Class ResponseUseCard is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseUseCard
 */
class ResponseUseCard extends BaseEntity {

    /**
     * Mã lỗi
     */
    private $code;

    /**
     * Mô tả lỗi
     */
    private $msg;

    /**
     * mã giao dịch
     */
    private $tranid;

    /**
     * mệnh giá
     */
    private $amount;

    function __constructor() {
        
    }

    public static function createAll($code, $msg, $tranid, $amount) {
        $instance = new self();
        $instance->setCode($code);
        $instance->setMsg($msg);
        $instance->setTranid($tranid);
        $instance->setAmount($amount);
        return $instance;
    }

    public function getCode() {
        return $this->code;
    }

    public function setCode($code) {
        $this->code = $code;
    }

    public function getMsg() {
        return $this->msg;
    }

    public function setMsg($msg) {
        $this->msg = $msg;
    }

    public function getAmount() {
        return $this->amount;
    }

    public function setAmount($amount) {
        $this->amount = $amount;
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
