<?php

require_once 'BaseEntity.php';

/**
 * Class ResponseRequest is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseRequest
 */
class ResponseRequest extends BaseEntity {

    /**
     * Mô tả lỗi
     */
    private $msg;

    /**
     * Mã giao dịch đối tác
     */
    private $tranid;

    /**
     * Mã lỗi
     */
    private $code;

    /**
     * Danh sách thẻ
     */
    private $listCards;

    function __constructor() {
        
    }

    public static function createAll($msg, $tranid, $code, $listCards) {
        $instance = new self();
        $instance->setCode($code);
        $instance->setListCards($listCards);
        $this->setMsg($msg);
        $this->setTranid($tranid);
        return $instance;
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

    public function getCode() {
        return $this->code;
    }

    public function setCode($code) {
        $this->code = $code;
    }

    public function getListCards() {
        return $this->listCards;
    }

    public function setListCards($listCards) {
        $this->listCards = $listCards;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
