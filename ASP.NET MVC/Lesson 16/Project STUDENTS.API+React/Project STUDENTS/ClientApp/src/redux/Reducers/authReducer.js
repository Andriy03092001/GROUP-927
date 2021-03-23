import { SIGN_IN, SIGN_UP } from "../types";

const initialState = {
    isAuth: false,
    token: null
}

export const authReducer = (state = initialState, action) => {
    switch (action.type) {
        case SIGN_IN: {
            return { ...state, isAuth: true }
        }
        case SIGN_UP: {
            return { ...state, isAuth: false }
        }

        default: return state;
    }
}