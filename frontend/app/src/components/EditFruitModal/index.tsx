import { FormEvent, useState } from "react";
import Modal from "react-modal";
import { Fruit } from "../FruitList/types";
import { Container } from "./styles/styles";

interface fruitExpandModalProps {
  isOpen: boolean;
  onRequestClose: () => void;
  fruit: Fruit;
}

export function FruitExpandModal({
  isOpen,
  onRequestClose,
  fruit,
}: fruitExpandModalProps) {

  const [result, setResult] = useState(0);

  async function handleEditFruit(event: FormEvent) {
    event.preventDefault();
  }

  return (
    <Modal
      isOpen={isOpen}
      onRequestClose={onRequestClose}
      overlayClassName="react-modal-overlay"
      className="react-modal-content"
    >
      <Container onSubmit={handleEditFruit}>
        <input disabled
          value={fruit.description}
        />
        <input disabled
          value={fruit.valueA}
        />
        <input disabled
          value={fruit.valueB}
        />
        <input disabled
          value={result}
        />

        <button type="submit"
                onClick={() => {
                  setResult(fruit.valueA/fruit.valueB);
                }}>Divisão</button>
        <button type="submit"
                onClick={() => {
                  setResult(fruit.valueA*fruit.valueB);
                }}>Multiplicação</button>
      </Container>
    </Modal>
  );
}
