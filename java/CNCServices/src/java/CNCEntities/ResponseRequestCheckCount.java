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
 * Class ResponseRequestCheckCount is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseRequestCheckCount
 */
public class ResponseRequestCheckCount extends BaseEntity {

    /**
     * Mã lỗi
     */
    private Integer code;
    /**
     * Mô tả lỗi
     */
    private String msg;
    /**
     * Danh sách số lượng thẻ còn theo nhà cung cấp
     */
    private String listprovider;

    public ResponseRequestCheckCount() {
    }

    public ResponseRequestCheckCount(Integer code, String msg, String listprovider) {
        this.code = code;
        this.msg = msg;
        this.listprovider = listprovider;
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

    public String getListprovider() {
        return listprovider;
    }

    public void setListprovider(String listprovider) {
        this.listprovider = listprovider;
    }

    @Override
    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("code", code);
            jo.put("msg", msg);
            jo.put("listprovider", listprovider);
        } catch (JSONException ex) {
            Logger.getLogger(ResponseRequestCheckCount.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
