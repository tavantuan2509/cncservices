<?php

abstract class BaseEntity implements JsonSerializable {

    public abstract function jsonSerialize();

    /* Set Value and Key Auto */

    public abstract function set($data);

    /* convert current object to Json String */

    public function toJson() {
        return json_encode($this);
    }

}
