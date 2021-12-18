import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { Input, Label, FormGroup } from 'reactstrap';

import { Button, Modal, ModalHeader, ModalBody, ModalFooter } from 'reactstrap';

export default function ProductEditModal(props) {
    const [modal, setModal] = useState(true);

    function toggle() {
        setModal(!modal);
    }

    return (
        <div>
            <Modal isOpen={modal} toggle={toggle}>
                <ModalHeader toggle={toggle}>Add New Product</ModalHeader>

                <ModalBody>
                    <FormGroup>
                        <Label for="productName">Product Name</Label>
                        <Input
                            type="text"
                            name="productName"
                            id="productName"
                            value={props.productName}
                        />
                    </FormGroup>

                    <FormGroup>
                        <Label for="productDescription">Description</Label>
                        <Input
                            type="textarea"
                            name="text"
                            id="exampleText"
                            value={props.productDescription}
                        />
                    </FormGroup>
                </ModalBody>

                <ModalFooter>
                    <Button color="primary" onClick={toggle}>
                        Save
                    </Button>{' '}
                    <Button color="secondary" onClick={toggle}>
                        Cancel
                    </Button>
                </ModalFooter>
            </Modal>
        </div>
    );
}
