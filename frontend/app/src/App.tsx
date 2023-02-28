import { useEffect, useState } from 'react';
import { api } from './service/api';
import { Fruit } from './components/FruitList/types';
import { FruitList } from './components/FruitList';
import { GlobalStyle } from './styles/global';
import { FruitExpandModal } from './components/EditFruitModal';
import { Header } from './components/Header';

export function App() {
  const [fruitExpandModal, setFruitExpandModal] = useState(false);
  const [fruitToExpand, setFruitToExpand] = useState<Fruit>({
    id: 0,
    description: "",
    valueA: 0,
    valueB: 0,
  });

  const [fruits, setFruits] = useState<Fruit[]>([]);

  useEffect(() => {
    api.get("/").then((response) => setFruits(response.data));
  }, []);

  function handleOpenEditFruitExpandModal() {
    setFruitExpandModal(true);
  }

  function handleCloseEditFruitExpandModal() {
    setFruitExpandModal(false);
  }

   return (
    <>
      <GlobalStyle />

      <Header />

      <FruitExpandModal
        isOpen={fruitExpandModal}
        onRequestClose={handleCloseEditFruitExpandModal}
        fruit={fruitToExpand}
      />

      <FruitList
        onOpenExpandFruitModal={handleOpenEditFruitExpandModal}
        fruits={fruits}
        setFruitToExpand={setFruitToExpand}
      />
    </>
  );
}

export default App;
