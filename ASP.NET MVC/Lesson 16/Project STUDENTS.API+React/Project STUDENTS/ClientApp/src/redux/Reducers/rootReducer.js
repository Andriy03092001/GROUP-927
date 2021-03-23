import { combineReducers } from "redux";
import { appReducer } from './appReducer'
import { authReducer } from './authReducer'

export const rootReducer = combineReducers({
    auth: authReducer,
    app: appReducer
})