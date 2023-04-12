import { HTMLInputTypeAttribute } from 'react';
import Modal from 'react-modal';

interface ModalProps {
  isOpen: boolean;
  onRequestClose: (e: React.MouseEvent<Element, MouseEvent> | React.KeyboardEvent<Element>) => void;
  children?: React.ReactNode;
}

const CustomModal = ({ isOpen, onRequestClose, children }: ModalProps) => {
  //Prevents closing or submitting modal form after opened
  const onAfterOpen = () => {
    let btn = Array.from(document.querySelectorAll('button'));
    let submit: HTMLInputElement[] = Array.from(document.querySelectorAll('input[type=submit]'));

    btn.forEach((btnElement) => (btnElement.disabled = true));
    submit.forEach((btnElement) => (btnElement.disabled = true));

    setTimeout(() => {
      btn.forEach((btnElement) => (btnElement.disabled = false));
      submit.forEach((btnElement) => (btnElement.disabled = false));
    }, 200);
  };

  return (
    <Modal
      appElement={document.getElementById('root') || undefined}
      isOpen={isOpen}
      onAfterOpen={onAfterOpen}
      overlayClassName="modal-overlay"
      className="modal-customstyle"
      contentLabel="Modal"
      onRequestClose={onRequestClose}
    >
      {children}
    </Modal>
  );
};

export default CustomModal;
