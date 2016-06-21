/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CNCEntities;

import org.json.JSONObject;

/**
 * Class BaseEntity is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class BaseEntity
 */
public abstract class BaseEntity {

    public abstract JSONObject getJsonEntity();

    public String toString() {
        JSONObject jsonObject = getJsonEntity();
        return jsonObject.toString();
    }
}
