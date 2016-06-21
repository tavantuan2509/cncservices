/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CNCEntities;

import java.util.logging.Level;
import java.util.logging.Logger;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Class ResponseTopup is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseTopup
 */
public class ResponseTopup extends BaseEntity {

    /**
     * Mã lỗi
     */
    private Integer code;
    /**
     * Mô tả lỗi
     */
    private String msg;
    /**
     * mã giao dịch
     */
    private String tranid;

    public ResponseTopup() {
    }

    public Integer getCode() {
        return code;
    }

    public void setCode(Integer code) {
        this.code = code;
    }

    public String getMsg() {
        return msg;
    }

    public void setMsg(String msg) {
        this.msg = msg;
    }

    public String getTranid() {
        return tranid;
    }

    public void setTranid(String tranid) {
        this.tranid = tranid;
    }

    public ResponseTopup(Integer code, String msg, String tranid) {
        this.code = code;
        this.msg = msg;
        this.tranid = tranid;
    }

    @Override
    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("code", code);
            jo.put("msg", msg);
            jo.put("tranid", tranid);
        } catch (JSONException ex) {
            Logger.getLogger(ResponseTopup.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
