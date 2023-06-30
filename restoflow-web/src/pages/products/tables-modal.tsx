import { Badge, Button, Modal } from 'flowbite-react'
import { useEffect, useRef, useState } from 'react'
import { useGet } from '../../hooks/use-get'
import { OccupiedTables, Table } from '../models'
import { API_ENDPOINTS } from '../../common/api-endpoints'
import { SearchIput } from './search-input'

interface Props {
  closeTablesModal: () => void
  onCofirm: (table: Table) => void
  loadingConfirm?: boolean
  isOpen?: boolean
}

export const TablesModal = ({ closeTablesModal, isOpen, onCofirm, loadingConfirm }: Props) => {
  const listRef = useRef<HTMLUListElement>(null)
  const [clickedTable, setClickedTable] = useState<Table>()
  const [filteredTables, setFilteredTables] = useState<Table[]>([])
  const { data: tableData, loading: tableLoading, error: tableError } = useGet<Table[]>({ url: API_ENDPOINTS.TABLES })
  const { data: occupiedTables } = useGet<OccupiedTables[]>({ url: API_ENDPOINTS.OCCUPIED_TABLES })

  useEffect(() => {
    setFilteredTables(tableData)
  }, [tableData])

  const handleTableClick = (table: Table) => {
    setClickedTable(table)
    // Store the current scroll position
    const scrollTop = listRef.current?.scrollTop

    // Restore the scroll position after re-render
    requestAnimationFrame(() => {
      if (listRef.current) {
        listRef.current.scrollTop = scrollTop || 0
      }
    })
  }

  const handleConfirm = () => {
    if (clickedTable) {
      onCofirm(clickedTable)
      // closeTablesModal()
    }
  }

  const handleDecline = () => {
    closeTablesModal()
    setClickedTable(undefined)
  }

  const filterTables = (search: string) => {
    const filtered = tableData.filter((t) => {
      const occupiedTable = occupiedTables.find((ot) => ot.tableId === t.id)
      const searchString = search.toLocaleLowerCase()
      return (
        t.seats.toString().includes(searchString) ||
        t.tableNumber.toString().includes(searchString) ||
        occupiedTable?.userName.toLowerCase().includes(searchString) ||
        (occupiedTable?.userName && 'busy'.includes(searchString)) ||
        (!occupiedTable?.userName && 'free'.includes(searchString))
      )
    })

    if (!search) {
      setFilteredTables(tableData)
    } else {
      setFilteredTables(filtered)
    }
  }

  const getTableState = (tableId: number) => {
    const occupiedTable = occupiedTables.find((oc) => oc.tableId === tableId)
    const state = occupiedTable ? 'failure' : 'success'
    const text = occupiedTable ? 'Busy' : 'Free'
    const servingPerson = occupiedTable ? occupiedTable.userName : ''
    return { state, text, servingPerson }
  }

  return (
    <>
      <Button onClick={closeTablesModal}>Toggle modal</Button>
      <Modal size={'lg'} show={isOpen} onClose={closeTablesModal}>
        <Modal.Header>Please select table from list</Modal.Header>
        <Modal.Body>
          <div>
            <SearchIput filterTables={filterTables} />
            <ul ref={listRef} className="h-96 px-3 pb-3 overflow-y-auto text-sm text-gray-700 dark:text-gray-200">
              {filteredTables.map((table) => (
                <li
                  key={table.id}
                  onClick={() => handleTableClick(table)}
                  className="flex items-center justify-between p-2 rounded hover:cursor-pointer hover:bg-gray-100 dark:hover:bg-gray-600 border-b"
                >
                  <div className="flex items-center">
                    <input
                      readOnly
                      id={table.id.toString()}
                      checked={table.id === clickedTable?.id}
                      type="checkbox"
                      className="w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-700 dark:focus:ring-offset-gray-700 focus:ring-2 dark:bg-gray-600 dark:border-gray-500"
                    />
                    <div className="flex flex-col gap-1 ml-4">
                      <label>
                        Table number:
                        <span className="ml-1 text-sm font-medium text-gray-900 rounded dark:text-gray-300">
                          {table.tableNumber}
                        </span>
                      </label>
                      {getTableState(table.id).servingPerson && (
                        <label>
                          Serving:
                          <span className="ml-1 text-sm font-medium text-gray-900 rounded dark:text-gray-300">
                            {getTableState(table.id).servingPerson}
                          </span>
                        </label>
                      )}
                    </div>
                  </div>
                  <div className="flex flex-col gap-1 ">
                    <Badge color={getTableState(table.id).state}>{getTableState(table.id).text}</Badge>
                    <label>
                      Seats:
                      <span className="ml-1 text-sm font-medium text-gray-900 rounded dark:text-gray-300">
                        {table.seats}
                      </span>
                    </label>
                  </div>
                </li>
              ))}
            </ul>
          </div>
        </Modal.Body>
        <Modal.Footer>
          <Button isProcessing={loadingConfirm} disabled={!clickedTable} onClick={handleConfirm}>
            Confirm
          </Button>
          <Button color="gray" onClick={handleDecline}>
            Decline
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  )
}
