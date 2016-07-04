<?php

/**
 * Class Util is 
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class Util
 */
class Util {

//    public static $agentCode = "CNCPublicAgentTest";
//    public static $agentKey = "CNCPublicAgentTest678%$$#^#";
    public static $agentCode = "softpintest";
    public static $agentKey = "softpintest@test123!@#";
    public static $cncServiceUrl = "http://testpay.pay365.vn/Softpin.asmx?WSDL";    

    /* Encrypt Fucntion */

    public static function Encrypt($key_seed, $input) {
        $input = trim($input);
        $block = mcrypt_get_block_size('tripledes', 'ecb');
        $len = strlen($input);
        $padding = $block - ($len % $block);
        $input .= str_repeat(chr($padding), $padding);
        // generate a 24 byte key from the md5 of the seed
        $key = substr(md5($key_seed), 0, 24);
        $iv_size = mcrypt_get_iv_size(MCRYPT_TRIPLEDES, MCRYPT_MODE_ECB);
        $iv = mcrypt_create_iv($iv_size, MCRYPT_RAND);
        // encrypt
        $encrypted_data = mcrypt_encrypt(MCRYPT_TRIPLEDES, $key, $input, MCRYPT_MODE_ECB, $iv);
        // clean up output and return base64 encoded
        return base64_encode($encrypted_data);
    }

    /* Decrypt function */

    public static function Decrypt($key_seed, $input) {
        $input = base64_decode($input);
        $key = substr(md5($key_seed), 0, 24);
        $text = mcrypt_decrypt(MCRYPT_TRIPLEDES, $key, $input, MCRYPT_MODE_ECB, '12345678');
        $block = mcrypt_get_block_size('tripledes', 'ecb');
        $packing = ord($text{strlen($text) - 1});
        if ($packing and ( $packing < $block)) {
            for ($P = strlen($text) - 1; $P >= strlen($text) - $packing; $P--) {
                if (ord($text{$P}) != $packing) {
                    $packing = 0;
                }
            }
        }
        $text = substr($text, 0, strlen($text) - $packing);
        return $text;
    }

}
