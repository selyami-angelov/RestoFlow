import useAxios from 'axios-hooks'

interface Props {
  url?: string
  manual?: boolean
}

interface PostDataProps {
  data?: unknown
  url?: string
}

export const usePost = <T,>({ url, manual }: Props) => {
  const [{ data, error, loading }, executePost] = useAxios<T>(
    {
      url,
      method: 'POST',
    },
    { manual }
  )

  const postData = (postData: PostDataProps) => {
    executePost(postData)
  }

  return { data: data ?? [], error, loading, postData }
}
