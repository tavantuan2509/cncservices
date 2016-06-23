<?php

require_once 'BaseEntity.php';

/**
 * Class ResponseTopup is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseTopup
 */
class ResponseTopup extends BaseEntity {

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

    function __construct() {
        
    }

    public static function createAll($code, $msg, $tranid) {
        $instance = new self();
        $instance->setCode($code);
        $instance->setMsg($msg);
        $instance->setTranid($tranid);
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
