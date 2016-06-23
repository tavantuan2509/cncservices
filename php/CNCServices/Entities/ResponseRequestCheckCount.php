<?php

require_once 'BaseEntity.php';

/**
 * Class ResponseRequestCheckCount is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseRequestCheckCount
 */
class ResponseRequestCheckCount extends BaseEntity {

    /**
     * Mã lỗi
     */
    private $code;

    /**
     * Mô tả lỗi
     */
    private $msg;

    /**
     * Danh sách số lượng thẻ còn theo nhà cung cấp
     */
    private $listprovider;

    function __constructor() {
        
    }

    public static function createAll($code, $msg, $listprovider) {
        $instance = new self();
        $instance->setCode($code);
        $instance->setListprovider($listprovider);
        $instance->setMsg($msg);
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

    public function getListprovider() {
        return $this->listprovider;
    }

    public function setListprovider($listprovider) {
        $this->listprovider = $listprovider;
    }

    public function jsonSerialize() {
        return get_object_vars($this);
    }

    public function set($data) {
        foreach ($data AS $key => $value)
            $this->{$key} = $value;
    }

}
