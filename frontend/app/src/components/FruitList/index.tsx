import { Fruit } from "./types";
import { Container } from "./styles/styles";

interface ListProps {
  onOpenExpandFruitModal: () => void;
  setFruitToExpand: any;
  fruits: Fruit[];
}

export function FruitList({
  onOpenExpandFruitModal,
  fruits,
  setFruitToExpand,
}: ListProps) {
  return (
    <Container>
      <table>
        <thead>
          <tr>
            <th>Descrição</th>
            <th>A</th>
            <th>B</th>
            <th>Ação</th>
          </tr>
        </thead>

        <tbody>
          {fruits
            ?.filter((fruit: Fruit) => fruit.id)
            .map((fruitFiltered: Fruit) => {
              return (
                <tr key={fruitFiltered.description}>
                  <td>
                    {fruitFiltered.description}
                  </td>
                  <td>
                    {fruitFiltered.valueA}
                  </td>
                  <td>
                    {fruitFiltered.valueB}
                  </td>

                  <div className="buttons">
                    <button
                      className="action-button"
                      onClick={() => {
                        onOpenExpandFruitModal();
                        setFruitToExpand(fruitFiltered);
                      }}
                    >
                      Selecionar
                    </button>
                  </div>
                </tr>
              );
            })}
        </tbody>
      </table>
    </Container>
  );
}
