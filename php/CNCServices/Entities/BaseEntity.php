<?php

abstract class BaseEntity implements JsonSerializable {

    public abstract function jsonSerialize();

    public abstract function set($data);

    public function toJson() {
        return json_encode($this);
    }
}
