import React, { Component, Fragment } from 'react';
import { Button } from 'antd';

class SignIn extends Component {

    state = {}

    render() {
        return (
            <Fragment>
                <h2> Sign in component </h2>
                <Button type="primary">Primary Button</Button>
            </Fragment>
        )
    }
}


export default SignIn;