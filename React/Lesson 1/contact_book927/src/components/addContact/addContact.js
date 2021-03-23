import React, { Component, Fragment } from 'react';

class AddContact extends Component {

    state = {
        name: "",
        number: "",
        image: 0,
        gender: "Women",
        MessageError: ""
    }

    handlerChangeInput = (e) => {
        var key = e.target.name;
        var value = e.target.value;

        this.setState({
            [key]: value
        })
    }

    isValid = () => {
        if (this.state.name === "" || this.state.number === "") {
            return false;
        } else {
            return true;
        }
    }

    submitForm = (e) => {
        e.preventDefault();
        if (this.isValid()) {
            this.setState({
                MessageError: ""
            })
            var newContact = {
                name: this.state.name,
                number: this.state.number,
                image: this.state.image,
                gender: this.state.gender,
            }
            console.log(newContact);

            this.props.addContact(newContact);
        } else {
            this.setState({
                MessageError: "Please, enter all fields!"
            })
        }
        // console.log(this.state)
    }

    render() {
        const { MessageError } = this.state;
        return (
            <form onSubmit={this.submitForm}>
                <div className="form-group">
                    <label>Contact name*</label>
                    <input type="text" className="form-control" name="name" onChange={this.handlerChangeInput} placeholder="Enter name" />
                </div>
                <div className="form-group">
                    <label>Contact number*</label>
                    <input type="text" className="form-control" name="number" onChange={this.handlerChangeInput} placeholder="Enter number" />
                </div>
                <div className="form-group">
                    <label>Contact number image</label>
                    <input type="number" className="form-control" name="image" onChange={this.handlerChangeInput} placeholder="Enter image number" />
                </div>
                <div className="form-group">
                    <label>Contact gender</label>
                    <select className="form-control" name="gender" onChange={this.handlerChangeInput}>
                        <option value="women">Women</option>
                        <option value="men">Men</option>
                    </select>

                </div>
                <p className="text-danger">{MessageError}</p>
                <button type="submit" className="btn btn-primary">Submit</button>
            </form>
        )
    }
}

export default AddContact;